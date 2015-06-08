//Problem 3. Rectangle area
//
//Write an expression that calculates rectangle’s area by given width and height.
//
//    Examples:
//width 	height 	area
//3 	4 	12
//2.5 	3 	7.5
//5 	5 	25

var i;

var width1 = 3,
    width2 = 2.5,
    width3 = 5,
    height1 = 4,
    height2 = 3,
    height3 = 5;

var widths = [
    width1,
    width2,
    width3];

var heights = [
    height1,
    height2,
    height3];

for (i = 0; i < widths.length; i+=1) {
    console.log('width: ' + widths[i] + ' height: ' + heights[i] + ' -> area: ' + getArea(widths[i], heights[i]));
}

function getArea(width, height) {
    return (width * height);
}