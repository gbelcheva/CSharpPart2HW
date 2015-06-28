/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
	  * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * // method removeAttribute(attribute)
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {

	function validateType(type){
		if (type !== '' && /^[a-z0-9]+$/.test(type.toLowerCase())) {
			return true;
		}

		return false;
	}

	function validateAttribute(name, value){
		if (name !== '' && /^[a-z0-9\-]+$/.test(name)) {
			return true;
		}

		return false;
	}

	function validateChild(child) {
		if (child instanceof domElement.constructor || typeof child === 'string') {
			return true;
		}

		return false;
	}

	function constructInnerHTML(obj){
		if (typeof obj._innerHTML !== 'undefined') {
			return obj._innerHTML;
		}

		var innerHTMLresult = '<' + obj.type;
		var keys = Object.keys(obj.attributes);
		if (keys.length !== 0) {
			keys.sort(function (k1, k2) {
				return k1.toLowerCase().localeCompare(k2.toLowerCase());
			});
			for (var key of keys)
			{
				if (obj.attributes.hasOwnProperty(key)) {
					innerHTMLresult += ' ' + key + '=\"' + obj.attributes[key] + '\"';
				}
			}
		}

		innerHTMLresult += '>' + obj.content;
		for (var child of obj.children)
		{
			innerHTMLresult += constructInnerHTML(child);
		}

		innerHTMLresult += '</' + obj.type + '>';
		return innerHTMLresult;
	}

	var domElement = (function () {

		var domElement = {
			init: function (type) {
				this.type = type;
				this._attributes = {};
				this._children = [];
				this._content = '';
				this._innerHTML;
				this._parent;

				return this;
			},
			get type() {
				return this._type;
			},
			set type(value) {
				if (!validateType(value)) {
					throw new Error('Invalid type');
				}
				this._type = value;
			},
			get attributes() {
				return this._attributes;
			},
			get children() {
				return this._children;
			},
			get content() {
				return this._content;
			},
			set content(value) {
				if (this.children.length < 1) {
					this._content = value;
				}
			},
			get innerHTML() {
				this._innerHTML = constructInnerHTML(this);
				return this._innerHTML;
			},
			get parent() {
				return this._parent;
			},
			set parent(value) {
				this._parent = value;
			},
			appendChild: function (child) {
				if (!validateChild(child)) {
					throw new Error('Invalid child element.');
				}

				if (typeof child === 'string') {
					child = {_innerHTML: child};
				}
				this.children.push(child);
				child.parent = this;

				return this;
			},
			addAttribute: function (name, value) {
				if (!validateAttribute(name, value)) {
					throw new Error('Invalid attribute.');
				}

				this.attributes[name] = value;

				return this;
			},
			removeAttribute: function (attribute) {
				if (this.attributes.hasOwnProperty(attribute)) {
					delete this.attributes[attribute];
				}
				else {
				  throw new Error('Attribute does not exist.')
				}
				return this;
			}
		};

		return domElement;
	}());

	return domElement;
}

module.exports = solve;