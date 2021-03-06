﻿namespace Computers.Common.Components 
{ 
    public class Ram 
    { 
        private int value; 

        internal Ram(int amount) 
        { 
            this.Amount = amount; 
        } 
        
        public int Amount { get; set; } 

        public void SaveValue(int newValue) 
        { 
            this.value = newValue; 
        } 

        public int LoadValue() 
        { 
            return this.value; 
        } 
    } 
}