using System;

class Reference {
    private string _reference = "";   // member attribute 
    public Reference () {}
    public Reference (string reference) { 
        _reference = reference;
    }
    public string GetReference () { // public method to make posible acces to the value of member attribute
        return _reference;
    }
}