function Person()
{
    this.sayHello = function () {

        alert("I am Say");
    }
}

Person.prototype.SayName = function () {
  
    alert("IamLee");

}


function Dog()
{

}



Dog.prototype = {
    constructor:Dog,
    name: "Petter",
    sayName: function () {
        alert(this.name);
    }

  
}
var dog = new Dog();
dog.sayName();
