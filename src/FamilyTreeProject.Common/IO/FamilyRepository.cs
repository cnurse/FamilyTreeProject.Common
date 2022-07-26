﻿using System.Collections.Generic;
using FamilyTreeProject.Common.Data;
using FamilyTreeProject.Common.Models;
using Naif.Core.Contracts;

namespace FamilyTreeProject.Common.IO
{
    public class FamilyRepository : BaseRepository<Family>
    {
        private readonly IFileStore _store;

        public FamilyRepository(IFileStore store)
        {
            Requires.NotNull(store);

            _store = store;
        }

        public override void Add(Family item)
        {
            Requires.NotNull(item);

            _store.AddFamily(item);
        }

        public override void Delete(Family item)
        {
            Requires.NotNull(item);

            _store.DeleteFamily(item);
        }

        public override IEnumerable<Family> GetAll()
        {
            return _store.Families;
        }

        public override void Update(Family item)
        {
            Requires.NotNull(item);

            _store.UpdateFamily(item);
        }
    }
}