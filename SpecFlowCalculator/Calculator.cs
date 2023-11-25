using System;
using System.ComponentModel;
namespace SpecFLowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Add() { return FirstNumber + SecondNumber; }
    }
}
