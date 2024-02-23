﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name"> Имя пола </param>
        /// <exception cref="ArgumentNullException"></exception>


        public Gender(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым или Null", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}