using System;
using System.Data;
using System.Runtime.CompilerServices;


namespace CodBlogFit.BL.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class User
    {
        #region Свойства

        /// <summary>
        /// Имя 
        /// </summary>

        public string Name { get; } // Установка пользователя ( 1 раз )
        
        /// <summary>
        /// Пол
        /// </summary>
     
        public Gender Gender { get; } // Запрещает изменять  пол человека ( при использование тольео (get) 
      
        /// <summary>
        /// Дата рождения 
        /// </summary>
        
        public DateTime BirthData { get; }
       
        /// <summary>
        /// Вес
        /// </summary>
      
        public double Weight { get; set; }
        /// <summary>
        /// Рост
        /// </summary>
      
        public double Height { get; set; }

        #endregion
        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="birthData">Дата рождения.</param>
        /// <param name="weight">Вес.</param>
        /// <param name="height">Рост.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public User(string name,
            Gender gender,
            DateTime birthData, 
            double weight, 
            double height)
        {
            #region Проверка условий 

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null", nameof(gender));
            }

            if (birthData < DateTime.Parse("01.01.1900") || birthData >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения ", nameof(birthData));
            }

            if (weight <= 0) // Вес человека не может быть меньше 0 
            {
                throw new ArgumentException("Вес не может быть меньше или равен нулю", nameof(weight));
            }

            if (height <= 0) // Рост человека не может быть меньше 0
            {
                throw new ArgumentException("Рост не может быть меньше либо равен нулю.", nameof(height));
            }
            #endregion 
          
            Name = name;
            Gender = gender;
            BirthData = birthData;
            Weight = weight;
            Height = height;


        }

        public override string ToString()
        {
            return Name;
        }

    }
} 