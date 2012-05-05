#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;


namespace TeamThing.Model	
{
	public partial class TeamMember
	{
		private string _firstName;
		public virtual string FirstName 
		{ 
		    get
		    {
		        return this._firstName;
		    }
		    set
		    {
		        this._firstName = value;
		    }
		}
		
		private string _lastName;
		public virtual string LastName 
		{ 
		    get
		    {
		        return this._lastName;
		    }
		    set
		    {
		        this._lastName = value;
		    }
		}
		
		private string _email;
		public virtual string Email 
		{ 
		    get
		    {
		        return this._email;
		    }
		    set
		    {
		        this._email = value;
		    }
		}
		
		private string _profileColor;
		public virtual string ProfileColor 
		{ 
		    get
		    {
		        return this._profileColor;
		    }
		    set
		    {
		        this._profileColor = value;
		    }
		}
		
		private int _teamMemberId;
		public virtual int TeamMemberId 
		{ 
		    get
		    {
		        return this._teamMemberId;
		    }
		    set
		    {
		        this._teamMemberId = value;
		    }
		}
		
		private IList<ThingBase> _things;
		public virtual IList<ThingBase> Things 
		{ 
		    get
		    {
		        return this._things;
		    }
		    set
		    {
		        this._things = value;
		    }
		}
		
		private Team _team;
		public virtual Team Team 
		{ 
		    get
		    {
		        return this._team;
		    }
		    set
		    {
		        this._team = value;
		    }
		}
		
		private Guid _apiKey;
		public virtual Guid ApiKey 
		{ 
		    get
		    {
		        return this._apiKey;
		    }
		    set
		    {
		        this._apiKey = value;
		    }
		}
		
	}
}