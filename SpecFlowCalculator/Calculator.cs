using System;
using System.ComponentModel;
namespace SpecFLowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; } // property prvniho cisla
        public int SecondNumber { get; set; } //proprety dru cislo
        public int Add() { return FirstNumber + SecondNumber; } //scitani dvou cisel
        public int Subtract() { return FirstNumber - SecondNumber; } //rozdil dvou cisel
        public int Multiplication() { return FirstNumber * SecondNumber; } //nasobeni dvou cisel
        public float Division() {  return FirstNumber / SecondNumber; } //deleni dvou cisel
        public int Residue() { return FirstNumber % SecondNumber; } //deleni zbytek dvou cisel
        public int EmpowermentFirstNumber() { return FirstNumber * FirstNumber; } //umocnovani normalni cislo
		public int EmpowermentSecondNumber() { return SecondNumber * SecondNumber; } //umocnovani zaporne cislo

	}
}
