﻿using Musify.Interfaces;
using System;

namespace Musify.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAlbumRepository Albums { get; }
        IArtistRepository Artists { get; }
        IGenreRepository Genres { get; }
        ISongRepository Songs { get; }
        IUserRepository Users { get; }

        void Complete();
    }
}