//Problem 8. Replace tags
//
//Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//
//Example:
//    input 	output
//<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p> 	<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>


var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p> 	<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>';

function replaceTags(text) {
    var tmpFirstPart,
        tmpSecondPart;
    while (text.indexOf('<a href="') > -1){
        tmpFirstPart = text.substring(0, text.indexOf('<a href="'));
        tmpSecondPart = text.substring(text.indexOf('<a href="')).replace('<a href="', '[URL=');
        tmpSecondPart = tmpSecondPart.replace('">', ']');
        tmpSecondPart = tmpSecondPart.replace('</a>', '[/URL]');
        text = tmpFirstPart + tmpSecondPart;
    }
    return text;
}


console.log(replaceTags(text));