﻿using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade 
    {
        get
        {
            return this.grade;
        }

        private set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Grade must be non-negative.");
            }

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Min grade must be non-negative.");
            }

            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        private set
        {
            if (value <= this.MinGrade)
            {
                throw new ArgumentOutOfRangeException("Max grade cannot be less than min grade.");
            }

            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get 
        {
            return this.comments;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Comments cannot be null or empty.");
            }

            this.comments = value;
        }
    }
}
