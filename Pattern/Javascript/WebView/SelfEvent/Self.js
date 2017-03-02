//主体并不知道并不知道观察者任何事情；即使观察者不存在也可独立运行
//观察者设计模式定义了对象间的一种一对多的依赖关系，以便一个对象的状态发生变化时，所有依赖于它的对象都得到通知并自动刷新。
function EventTarget() {
    this.handlers = [];
}

EventTarget.prototype = {
    constructor: EventTarget,
    addHandler: function (type, handler) {
        if (typeof this.handlers[type] == "undefined")
        {
            this.handlers[type] = [];
        }
        this.handlers[type].push(handler);
    },
    fire: function (event) {

        if (!event.target)
        {
            event.target = this;
        }
        if (this.handlers[event.type] instanceof Array)
        {

            var handlers = this.handlers[event.type];

            for (var i = 0, len = handlers.length; i < len; i++)
            {
                handlers[i](event);
            }
        }
    },
    removeHandler: function (type,handler) {
         
        if (this.handlers[type] instanceof Array)
        {
            var handlers = this.handlers[type];

            for (var i = 0, len = handlers.length; i < len; i++)
            {
                  
                if (handlers[i] == handler)
                {
                    break;
                }
            }

            handlers.splice(i,1);
        }

    }
};

function handleMessage(event)
{
    alert("messagae  received:"+event.message);
}

var eventTarget = new EventTarget();

eventTarget.addHandler("showMessage", handleMessage);


eventTarget.fire({ type: "showMessage",message:"hellorWord" });


function Person(name,age)
{
    EventTarget.call(this);

    this.name = name;

    this.age = age;
}


function inheritPrototype(subType, superType)
{
    var prototype = Object(superType.prototype);

    prototype.constructor = subType;

    subType.prototype = prototype;

}
inheritPrototype(Person, EventTarget);

Person.prototype.say = function (message) {
    
    this.fire({type:"message",message:message});

}


var person = new Person("xxx","s");

function introduceSelf(event) {
    alert("My age:" + event.target.name+"  "+event.message);
}


person.addHandler("message",introduceSelf);

person.say("hei");