// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{

	public partial class Dependee
	{		
		internal override void OnBuild(global::Allors.IObjectBuilder objectBuilder)
		{
			var builder = (DependeeBuilder)objectBuilder;
			

			if(builder.Subcounter.HasValue)
			{
				this.Subcounter = builder.Subcounter.Value;
			}			
					

			if(builder.Counter.HasValue)
			{
				this.Counter = builder.Counter.Value;
			}			
					

			if(builder.DeleteDependent.HasValue)
			{
				this.DeleteDependent = builder.DeleteDependent.Value;
			}			
		

			this.Subdependee = builder.Subdependee;


		}
	}

	public partial class DependeeBuilder : Allors.ObjectBuilder<Dependee> , global::System.IDisposable
	{		
		public DependeeBuilder(Allors.ISession session) : base(session)
	    {
	    }

				public Subdependee Subdependee {get; set;}

				/// <exclude/>
				public DependeeBuilder WithSubdependee(Subdependee value)
		        {
		            if(this.Subdependee!=null){throw new global::System.ArgumentException("One multicplicity");}
					this.Subdependee = value;
		            return this;
		        }		

				
				public global::System.Int32? Subcounter {get; set;}

				/// <exclude/>
				public DependeeBuilder WithSubcounter(global::System.Int32? value)
		        {
				    if(this.Subcounter!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Subcounter = value;
		            return this;
		        }	

				public global::System.Int32? Counter {get; set;}

				/// <exclude/>
				public DependeeBuilder WithCounter(global::System.Int32? value)
		        {
				    if(this.Counter!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.Counter = value;
		            return this;
		        }	

				public global::System.Boolean? DeleteDependent {get; set;}

				/// <exclude/>
				public DependeeBuilder WithDeleteDependent(global::System.Boolean? value)
		        {
				    if(this.DeleteDependent!=null){throw new global::System.ArgumentException("One multicplicity");}
		            this.DeleteDependent = value;
		            return this;
		        }	


	}

	public partial class Dependees : global::Allors.ObjectsBase<Dependee>
	{
		public static readonly DependeeMeta Meta = DependeeMeta.Instance;

		public Dependees(Allors.ISession session) : base(session)
		{
		}

		public override Allors.Meta.Composite ObjectType
		{
			get
			{
				return Meta.ObjectType;
			}
		}
	}

}