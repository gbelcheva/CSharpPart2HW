//Problem 1. Planar coordinates
//
//Write functions for working with shapes in standard Planar coordinate system.
//    Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//    Check if three segment lines can form a triangle.

var a,
    b,
    c,
    aB,
    bC,
    cA;

function Point (x, y) {
    this.x = x;
    this.y = y;
}

Point.prototype.toString = function() {
    return 'P(' + this.x + ', ' + this.y + ')';
};

function Line (p1, p2) {
    this.p1 = p1;
    this.p2 = p2;
}

Line.prototype.toString = function() {
    return 'L(' + this.p1.toString() + ', ' + this.p2.toString() + ')';
};

Line.prototype.getLength = function () {
    return Math.sqrt(
        (this.p1.x - this.p2.x) * (this.p1.x - this.p2.x) +
        (this.p1.y - this.p2.y) * (this.p1.y - this.p2.y)
    );
}

function checkTriangle(line1, line2, line3) {
    return line1.getLength() < line2.getLength() + line3.getLength() &&
           line2.getLength() < line3.getLength() + line1.getLength() &&
           line3.getLength() < line1.getLength() + line2.getLength();
}


a = new Point(-1, -1);
b = new Point(2, -1);
c = new Point(0, 5);
aB = new Line(a, b);
bC = new Line(b, c);
cA = new Line(c, a);

console.log('Distance between ' + a.toString() + ' and ' + b.toString() + ' is ' + aB.getLength());

console.log(aB.toString() + ', ' + bC.toString() + ' and ' + cA.toString() + ' can form a triangle? ' + checkTriangle(aB,bC,cA));