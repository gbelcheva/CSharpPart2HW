//Problem 6. Point in Circle
//
//Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
//
//Examples:
//x 	y 	inside
//0 	1 	 true
//-5 	0 	 true
//-4 	5 	 false
//1.5 	-3 	 true
//-4 	-3.5 	false
//100 	-30 	false
//0 	0 	    true
//0.2 	-0.8 	true
//0.9 	-4.93 	false
//2 	2.655 	true

var i,
    radius = 5,
    centerX = 0,
    centerY = 0;

var x1 = 0,
    x2 = -5,
    x3 = -4,
    x4 = 1.5,
    x5 = -4,
    x6 = 100,
    x7 = 0,
    x8 = 0.2,
    x9 = 0.9,
    x10 = 2,
    y1 = 1,
    y2 = 0,
    y3 = 5,
    y4 = -3,
    y5 = -3.5,
    y6 = -30,
    y7 = 0,
    y8 = -0.8,
    y9 = -4.93,
    y10 = 2.655;

var x = [
    x1,
    x2,
    x3,
    x4,
    x5,
    x6,
    x7,
    x8,
    x9,
    x10];

var y = [
    y1,
    y2,
    y3,
    y4,
    y5,
    y6,
    y7,
    y8,
    y9,
    y10];

for (i = 0; i < x.length; i += 1) {
    console.log('Is P(' + x[i] + ',' + y[i] + ') inside the circle K({' + centerX + ',' + centerY + '}, ' + radius + ')? -> ' + isInsideCircle(x[i], y[i], centerX, centerY, radius));
}

function isInsideCircle(x, y, cX, cY, r) {
    return (x - cX) * (x - cX) + (y - cY) * (y - cY) <= r * r;
}