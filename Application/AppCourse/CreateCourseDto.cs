﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.AppCourse
{
    public class CreateCourseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PathId { get; set; }
    }
}