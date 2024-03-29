// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectsGraph.cs" company="Allors bvba">
//   Copyright 2002-2013 Allors bvba.
//
// Dual Licensed under
//   a) the General Public Licence v3 (GPL)
//   b) the Allors License
//
// The GPL License is included in the file gpl.txt.
// The Allors License is an addendum to your contract.
//
// Allors Applications is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// For more information visit http://www.allors.com/legal
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors
{
    using System;
    using System.Collections.Generic;

    using Allors.Domain;

    public class ObjectsGraph
    {
        private readonly Dictionary<IObjects, ObjectsNode> objectsNodeByObjects;

        public ObjectsGraph()
        {
            this.objectsNodeByObjects = new Dictionary<IObjects, ObjectsNode>();
        }

        public void Invoke(Action<IObjects> action)
        {
            foreach (var dictionaryEntry in this.objectsNodeByObjects)
            {
                var derivationNode = dictionaryEntry.Value;
                derivationNode.Execute(action);
            }
        }

        public ObjectsNode Add(IObjects objects)
        {
            ObjectsNode objectsNode;
            if (!this.objectsNodeByObjects.TryGetValue(objects, out objectsNode))
            {
                objectsNode = new ObjectsNode(objects);
                this.objectsNodeByObjects.Add(objects, objectsNode);
            }

            return objectsNode;
        }

        public void AddDependency(IObjects dependent, IObjects dependency)
        {
            var objectsNode = this.Add(dependent);
            var dependencyNode = this.Add(dependency);
            objectsNode.AddDependency(dependencyNode);
        }
    }
}