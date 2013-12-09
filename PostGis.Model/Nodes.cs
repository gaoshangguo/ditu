﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Nodes
    {
        public Nodes() { }
        public long Id { get; set; }
        public long Version { get; set; }
        public Changesets Changesets { get; set; }
        public bool Visible { get; set; }
        public long Tile { get; set; }
        public string Timestamp { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as Nodes;
            if (t == null) return false;
            if (Id == t.Id
             && Version == t.Version)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Id.GetHashCode();
            hash = (hash * 397) ^ Version.GetHashCode();

            return hash;
        }
        #endregion
    }
}