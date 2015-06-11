//Problem 2. HTML binding
//
//Write a function that puts the value of an object into the content/attributes of HTML tags.
//    Add the function to the String.prototype
//
//Example 1:
//
//input
//
//var str = '<div data-bind-content="name"></div>';
//str.bind(str, {name: 'Steven'});
//
//output
//
//<div data-bind-content="name">Steven</div>
//
//    Example 2:
//
//input
//
//var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></à>'
//str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'});
//
//output
//
//<a data-bind-content="name" data-bind-href="link" data-bind-class="name" href="http://telerikacademy.com" class="Elena">Elena</à>

var str1 = '<div data-bind-content=\"name\"></div>',
    obj1 = {name: 'Steven'},
    str2 = '<a data-bind-content=\"name\" data-bind-href=\"link\" data-bind-class=\"name\"></a>',
    obj2 = {name: 'Elena', link: 'http://telerikacademy.com'};

String.prototype.bind = function (str, obj) {
    var i,
        len,
        result = str,
        attributes = str.match(/data-bind-(\w+)\W+"\w+"/g),
        keys = Object.keys(obj);

    for (var attr of attributes){
        var attrPlace = attr.match(/data-bind-(\w+)/)[0].replace('data-bind-', ''),
            attrValue = attr.match(/"(\w+)"/)[1];
        for (i = 0, len = keys.length; i < len; i += 1) {
            if (attrValue === keys[i]) {
                switch (attrPlace) {
                    case 'content':
                        result = result.replace('<\/', obj[keys[i]] + '<\/');
                        break;
                    default:
                        result = result.replace('>', ' ' + attrPlace + '=\"' + obj[keys[i]] + '\">');
                        break;
                }
            }
        }
    }
    return result;
}

console.log(str1.bind(str1,obj1));
console.log(str2.bind(str2,obj2));