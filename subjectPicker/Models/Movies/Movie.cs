using System;

namespace subjectPicker.Models.Movies
{
    public class Movie
    {
        /// <summary>
        /// Movie id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Movie name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Movie genere
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        public DateTime CreatedAt { get; set; }

        public string Poster { get; set; }
    }
}