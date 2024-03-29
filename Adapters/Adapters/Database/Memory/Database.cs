// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Database.cs" company="Allors bvba">
//   Copyright 2002-2013 Allors bvba.
// Dual Licensed under
//   a) the Lesser General Public Licence v3 (LGPL)
//   b) the Allors License
// The LGPL License is included in the file lgpl.txt.
// The Allors License is an addendum to your contract.
// Allors Platform is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// For more information visit http://www.allors.com/legal
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Adapters.Database.Memory
{
    using System;
    using System.Xml;

    public abstract class Database : Population, IDatabase
    {
        private readonly Guid id;

        private readonly IWorkspaceFactory workspaceFactory;

        protected Database(Configuration configuration)
            : base(configuration)
        {
            this.id = configuration.Id;
            this.workspaceFactory = configuration.WorkspaceFactory;
        }

        public override event SessionCreatedEventHandler SessionCreated;

        public event ObjectNotLoadedEventHandler ObjectNotLoaded;

        public event RelationNotLoadedEventHandler RelationNotLoaded;

        public override Guid Id
        {
            get { return this.id; }
        }

        public override bool IsDatabase
        {
            get
            {
                return true;
            }
        }

        public override bool IsWorkspace
        {
            get
            {
                return false;
            }
        }

        public bool IsShared
        {
            get
            {
                return false;
            }
        }

        internal abstract Session Session { get; }

        public override ISession CreateSession()
        {
            return this.CreateDatabaseSession();
        }

        public IWorkspace CreateWorkspace()
        {
            if (this.workspaceFactory == null)
            {
                throw new Exception("No workspacefactory defined");
            }

            return this.workspaceFactory.CreateWorkspace(this);
        }

        public void Recover()
        {
        }

        IDatabaseSession IDatabase.CreateSession()
        {
            return this.CreateDatabaseSession();
        }

        public IDatabaseSession CreateDatabaseSession()
        {
            if (this.SessionCreated != null)
            {
                this.SessionCreated.Invoke(this, new SessionCreatedEventArgs(this.Session));
            }

            return this.Session;
        }

        public void Init()
        {
            this.Session.Init();

            this.Properties = null;
        }

        public override void Load(XmlReader reader)
        {
            this.Init();

            var load = new Load(this.Session, reader);
            load.Execute();
            
            this.Session.Commit();
        }

        public override void Save(XmlWriter writer)
        {
            this.Session.Save(writer);
        }

        internal void OnObjectNotLoaded(Guid metaTypeId, string allorsObjectId)
        {
            var args = new ObjectNotLoadedEventArgs(metaTypeId, allorsObjectId);
            if (this.ObjectNotLoaded != null)
            {
                this.ObjectNotLoaded(this, args);
            }
            else
            {
                throw new Exception("Object not loaded: " + args);
            }
        }

        internal void OnRelationNotLoaded(Guid relationTypeId, string associationObjectId, string roleContents)
        {
            var args = new RelationNotLoadedEventArgs(relationTypeId, associationObjectId, roleContents);
            if (this.RelationNotLoaded != null)
            {
                this.RelationNotLoaded(this, args);
            }
            else
            {
                throw new Exception("RelationType not loaded: " + args);
            }
        }
    }
}