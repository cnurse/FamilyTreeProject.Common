﻿using System.Collections.Generic;
using FamilyTreeProject.Common.Data;
using FamilyTreeProject.Common.Models;
using Naif.Core.Contracts;

namespace FamilyTreeProject.Common.IO
{
    public class SourceRepository: BaseRepository<Source>
    {
        private readonly IFileStore _store;

        public SourceRepository(IFileStore store)
        {
            Requires.NotNull(store);

            _store = store;
        }

        public override void Add(Source item)
        {
            Requires.NotNull(item);

            _store.AddSource(item);
        }

        public override void Delete(Source item)
        {
            Requires.NotNull(item);

            //_store.DeleteRepository(item);
        }

        public override IEnumerable<Source> GetAll()
        {
            return _store.Sources;
        }

        public override void Update(Source item)
        {
            Requires.NotNull(item);

            //_store.UpdateRepositoryl(item);
        }
    }
}