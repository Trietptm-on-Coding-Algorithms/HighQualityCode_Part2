﻿using System;

public class CSharpExam : Exam
{
    private int score;

    public int Score
    {
        get
        {
            return this.score;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Score cannot be less than 0!");
            }
            else if (value > 100)
            {
                throw new ArgumentException("Score cannot be greater than 100!");
            }

            this.score = value;
        }
    }

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
