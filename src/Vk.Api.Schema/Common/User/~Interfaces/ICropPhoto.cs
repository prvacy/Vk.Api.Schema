﻿using System;
using Vk.Api.Schema.Common.Media.Photo;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления данных об обрезанной фотографии
    /// из профиля пользователя
    /// </summary>
    public interface ICropPhoto
    {
        /// <summary>
        /// Фотография пользователя, из которой
        /// вырезается главное фото профиля
        /// </summary>
        IPhoto Photo { get; }

        /// <summary>
        /// Координаты вырезанной части фотографии профиля
        /// </summary>
        Rect Crop { get; }

        /// <summary>
        /// Координаты вырезанной квадратной миниатюры фотографии профиля
        /// </summary>
        Rect Rect { get; }
    }
}
