using System;

/*
Class members:
in java:
    fields, constructirs, methods, getters, and setters
in c#:
    fields, properties methods, constructors
    fields - characteristics of your object 
    methods -behavior of your object 
    constructors - special method, that gets called when you create an instance of an object
    -if no constructor exists, there's a default one that is created for you
    properties - "smart fields"
        - in java you need to have a field for a getter and setter to exist
        - wrapper for a field, works as a getter and setter for a private backing field,

POCO - plain c# object 
    - class that holds data
*/
namespace ToHModels
{
    /// <summary>
    /// Data structure used for modeling a hero.
    /// </summary>
    public class Hero
    {
        public string HeroName { get; set; }
    }
}
