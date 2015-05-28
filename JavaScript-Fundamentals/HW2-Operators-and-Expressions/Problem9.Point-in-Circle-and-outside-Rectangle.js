//Problem 9. Point in Circle and outside Rectangle
//
//Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
//
//Examples:
//x 	y 	inside K & outside of R
//1 	4 	yes
//3 	2 	yes
//0 	1 	no
//4 	1 	no
//2 	0 	no
//4 	0 	no
//2.5 	1.5 	yes
//3.5 	1.5 	yes
//-100 	-100 	no

var i,
    circle = [1, 1, 3],
    rectangle = [1, -1, -1, 5],
    isInsideCircle,
    isOutsideRectangle;

var x1 =1,
    x2 = 3,
    x3 = 0,
    x4 = 4,
    x5 = 2,
    x6 = 4,
    x7 = 2.5,
    x8 = 3.5,
    x9 = -100,
    y1 =4,
    y2 = 2,
    y3 = 1,
    y4 = 1,
    y5 = 0,
    y6 = 0,
    y7 = 1.5,
    y8 = 1.5,
    y9 = -100;

var x = [
    x1,
    x2,
    x3,
    x4,
    x5,
    x6,
    x7,
    x8,
    x9];

var y = [
    y1,
    y2,
    y3,
    y4,
    y5,
    y6,
    y7,
    y8,
    y9];

for (i = 0; i < x.length; i += 1) {
    console.log('Is P(' + x[i] + ',' + y[i] + ') inside K' +  ' and outside R? -> ' + isInCircleOutRectangle(x[i], y[i], circle[0], circle[1], circle[2], rectangle[0], rectangle[1], rectangle[2], rectangle[3]));
}

function isInCircleOutRectangle(x, y, cX, cY, r, rY1, rY2, rX1, rX2) {
    isInsideCircle = (x - cX) * (x - cX) + (y - cY) * (y - cY) <= r * r;
    isOutsideRectangle = (y > rY1 || y < rY2 || x < rX1 || x > rX2);
    if (isInsideCircle && isOutsideRectangle){
        return 'yes';
    }
    return 'no';
}