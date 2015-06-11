//Problem 12. Generate list
//
//Write a function that creates a HTML <ul> using a template for every HTML <li>.
//The source of the list should be an array of elements.
//    Replace all placeholders marked with �{�}� with the value of the corresponding property of the object.
//
//    Example: HTML:
//
//    <div data-type="template" id="list-item">
//    <strong>-{name}-</strong> <span>-{age}-</span>
///div>
//
//JavaScript:
//
//var people = [{name: 'Peter', age: 14},�];
//var tmpl = document.getElementById('list-item').innerHtml;
//var peopleList = generateList(people, template);
////peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>�</li>�</ul>'


var people = [
    {name: 'Peter', age: 14},
    {name: 'Sasho', age: 22},
    {name: 'Maria', age: 20},
    {name: 'Atanas', age: 35}];

var template = this.document.getElementById('list-item').innerHTML;
//var peopleList = generateList(people, template);

document.body.removeChild(this.document.getElementById('list-item'));

function generateList(people, template){
    var list = document.createElement('ul');

    for (var person of people) {
        var item = document.createElement('li'),
            tmp = template;

        for (var property in person) {
            tmp = tmp.replace(new RegExp('\\-{' + property + '\\}-', "g"), person[property]);
        }

        item.innerHTML = tmp;
        list.appendChild(item);
    }
    document.body.appendChild(list);
}