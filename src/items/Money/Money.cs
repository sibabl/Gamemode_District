//Item
datablock ItemData(OneDollarItem)
{
	category = "Weapon";  // Mission editor category;
	className = "Weapon"; // For inventory system

	 // Basic Item Properties
	shapeFile = "./1/MoneyH.dts";
	mass = 1;
	density = 0.2;
	elasticity = 0.2;
	friction = 0.6;
	emap = true;

	//gui stuff
	uiName = "$1 Bill";
	iconName = "";

	doColorShift = true;
	colorShiftColor = "0.0 0.501 0.0 1.0";

	 // Dynamic properties defined by the scripts
	image = OneDollarImage;
	canDrop = true;

	rotate = 1;

	isMoney = 1;
	worth = 1;
};

//Image
datablock ShapeBaseImageData(OneDollarImage)
{
	// Basic Item properties
	shapeFile = "./1/MoneyV.dts";
	emap = true;

	// Specify mount point & offset for 3rd person, and eye offset
	// for first person rendering.
	mountPoint = 0;
	offset = "0 0.05 0.05";

	// When firing from a point offset from the eye, muzzle correction
	// will adjust the muzzle vector to point to the eye LOS point.
	// Since this weapon doesn't actually fire from the muzzle point,
	// we need to turn this off.  
	correctMuzzleVector = false;

	//eyeOffset = "0.7 1.2 -0.25";

	// Add the WeaponImage namespace as a parent, WeaponImage namespace
	// provides some hooks into the inventory system.
	className = "WeaponImage";

	// Projectile && Ammo.
	item = OneDollarItem;
	ammo = " ";
	projectile = "";
	projectileType = Projectile;

	doColorShift = true;
	colorShiftColor = "0.0 0.501 0.0 1.0";

	//melee particles shoot from eye node for consistancy
	melee = true;
	doRetraction = false;
	//raise your arm up or not
	armReady = true;

	//casing = " ";

	// Images have a state system which controls how the animations
	// are run, which sounds are played, script callbacks, etc. This
	// state system is downloaded to the client so that clients can
	// predict state changes and animate accordingly.  The following
	// system supports basic ready->fire->reload transitions as
	// well as a no-ammo->dryfire idle state.

	// Initial start up state
	stateName[0]                     = "Activate";
	stateTimeoutValue[0]             = 0.5;
	stateSound[0]                    = weaponSwitchSound;

	isMoney = 1;
	worth = 1;
};

datablock ItemData(FiveDollarItem : OneDollarItem)
{
	shapeFile = "./5/MoneyH.dts";
	uiName = "$5 Bill";

	image = FiveDollarImage;
	worth = 5;
};

datablock ShapeBaseImageData(FiveDollarImage : OneDollarImage)
{
	shapeFile = "./5/MoneyV.dts";

	item = FiveDollarItem;
	worth = 5;
};

datablock ItemData(TenDollarItem : OneDollarItem)
{
	shapeFile = "./10/MoneyH.dts";
	uiName = "$10 Bill";

	image = TenDollarImage;
	worth = 10;
};

datablock ShapeBaseImageData(TenDollarImage : OneDollarImage)
{
	shapeFile = "./10/MoneyV.dts";

	item = TenDollarItem;
	worth = 10;
};

datablock ItemData(TwentyDollarItem : OneDollarItem)
{
	shapeFile = "./20/MoneyH.dts";
	uiName = "$20 Bill";

	image = TwentyDollarImage;
	worth = 20;
};

datablock ShapeBaseImageData(TwentyDollarImage : OneDollarImage)
{
	shapeFile = "./20/MoneyV.dts";

	item = TwentyDollarItem;
	worth = 20;
};

datablock ItemData(FiftyDollarItem : OneDollarItem)
{
	shapeFile = "./50/MoneyH.dts";
	uiName = "$50 Bill";

	image = FiftyDollarImage;
	worth = 50;
};

datablock ShapeBaseImageData(FiftyDollarImage : OneDollarImage)
{
	shapeFile = "./50/MoneyV.dts";

	item = FiftyDollarItem;
	worth = 50;
};

datablock ItemData(HundredDollarItem : OneDollarItem)
{
	shapeFile = "./100/MoneyH.dts";
	uiName = "$100 Bill";

	image = HundredDollarImage;
	worth = 100;
};

datablock ShapeBaseImageData(HundredDollarImage : OneDollarImage)
{
	shapeFile = "./100/MoneyV.dts";

	item = HundredDollarItem;
	worth = 100;
};