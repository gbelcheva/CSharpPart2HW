Potato potato;
//... 
if (potato != null)
{
   if(!(potato.HasNotBeenPeeled || potato.IsRotten))
    {
        Cook(potato);
    }
}

bool xIsInRange = MIN_X <= x && x <= MAX_X;
bool yIsInRange = MIN_Y <= y && y <= MAX_Y;

if (xIsInRange && 
    yIsInRange && 
    !shouldNotVisitCell)
{
   VisitCell();
}