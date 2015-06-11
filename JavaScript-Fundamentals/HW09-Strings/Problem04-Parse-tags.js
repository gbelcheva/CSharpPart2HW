//Problem 4. Parse tags
//
//You are given a text. Write a function that changes the text in all regions:
//
//    <upcase>text</upcase> to uppercase.
//<lowcase>text</lowcase> to lowercase
//<mixcase>text</mixcase> to mix casing(random)
//
//Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.
//
//The expected result:
//    We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.
//
//Note: Regions can be nested.

var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';

function parseTags(text) {
    var i,
        j,
        len,
        tags = [
            '<mixcase>',
            '<upcase>',
            '<lowcase>'
            ];
    for (var tag of tags) {
        for (i = 0; i < text.length; i += 1) {
            var t = text.substr(i, tag.length).toLowerCase();
            if (t === tag.toLowerCase()) {
                for (j = i; i < text.length; j += 1) {
                    var endTag = '</' + tag.substr(1,tag.length - 1);
                    t = text.substr(j, endTag.length).toLowerCase();
                    if (t === endTag.toLowerCase()) {
                        var portion = text.slice(i, j + endTag.length);
                        switch (tag) {
                            case '<upcase>':
                                text = text.replace(portion, portion.substr(tag.length, portion.length - tag.length - endTag.length).toUpperCase());
                                break;
                            case '<lowcase>':
                                text = text.replace(portion, portion.substr(tag.length, portion.length - tag.length - endTag.length).toLowerCase());
                                break;
                            case '<mixcase>':
                                var mixed = '';
                                var k,
                                    len2;
                                for (k = 0, len = portion.substr(tag.length, portion.length - tag.length - endTag.length).length; k < len; k += 1) {
                                    if (Math.random() > 0.5) {
                                        mixed += portion.substr(tag.length, portion.length - tag.length - endTag.length)[k].toUpperCase();
                                    }
                                    else {
                                        mixed += portion.substr(tag.length, portion.length - tag.length - endTag.length)[k].toLowerCase();
                                    }
                                }
                                text = text.replace(portion, mixed);
                                break;
                            default: break;
                        }
                        break;
                    }
                }
            }
        }
    }
    return text;
}


console.log(parseTags(text));