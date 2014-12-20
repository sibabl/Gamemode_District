package ItemRotating
{
	function ItemData::onAdd(%this, %obj)
	{
		if(%this.rotate)
		%obj.rotate = 1;

		Parent::onAdd(%this, %obj);
	}
};
activatePackage(ItemRotating);