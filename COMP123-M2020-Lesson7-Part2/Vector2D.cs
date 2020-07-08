using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_M2020_Lesson7_Part2
{
    public class Vector2D
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private float m_x;
        private float m_y;

        // CONSTRUCTOR
        public Vector2D(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }

        // PUBLIC PROPERTIES
        public float x
        {
            get
            {
                return this.m_x;
            }

            set
            {
                this.m_x = value;
            }
        }

        public float y
        {
            get
            {
                return this.m_y;
            }

            set
            {
                this.m_y = value;
            }
        }

        /// <summary>
        /// This method overrides the built-in ToString method
        /// It returns a string that is formatted as (x, y)
        /// where x and y are the property values
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "(" + this.x + ", " + this.y + ")";
        }

        public string StringEncode()
        {
            return this.x + "," + this.y;
        }

        public void StringDecode(string codedString)
        {
            string[] coordinates = codedString.Split(',');

            this.x = Convert.ToSingle(coordinates[0]);
            this.y = Convert.ToSingle(coordinates[1]);
        }
    }
}