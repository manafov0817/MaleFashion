﻿using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class PhotoManager : IPhotoService
    {
        private IPhotoRepository _photoRepository;
        public PhotoManager ( IPhotoRepository photoRepository )
        {
            _photoRepository = photoRepository;
        }
        public void Create ( Photo entity )
        {
            _photoRepository.Create(entity);
        }

        public void Delete ( Photo entity )
        {
            _photoRepository.Delete(entity);
        }

        public List<Photo> GetAll ()
        {
            return _photoRepository.GetAll( );
        }

        public Photo GetById ( int id )
        {
            return _photoRepository.GetById(id);
        }

        public void Update ( Photo entity )
        {
            _photoRepository.Update(entity);
        }
    }
}
