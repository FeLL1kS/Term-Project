﻿using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.BusinessLayer.Interfaces
{
    public interface IReaderProcess
    {
        /// <summary>
        /// Возвращает список читателей
        /// </summary>
        /// <returns>Список читателей</returns>
        IList<ReaderDto> GetList();

        /// <summary>
        /// Возвращает читателя по ID
        /// </summary>
        /// <param name="id">ID читателя</param>
        /// <returns>Читатель</returns>
        ReaderDto Get(int id);

        /// <summary>
        /// Добавляет читателя
        /// </summary>
        /// <param name="reader">Читатель</param>
        void Add(ReaderDto reader);

        /// <summary>
        /// Обновляет данные об читателе
        /// </summary>
        /// <param name="reader">Читатель, которого нужно изменить</param>
        void Update(ReaderDto reader);

        /// <summary>
        /// Удаляет читателя
        /// </summary>
        /// <param name="id">ID читателя</param>
        void Delete(int id);
    }
}
