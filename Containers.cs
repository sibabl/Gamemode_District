function servercmdDistrictCDrop(%cl, %vec0)
{
	if(!isObject(%pl = %cl.player)) return;
	if(!isObject(%list = DistrictContainerList)) return;
	%cid0 = getWord(%vec0, 0);
	if(%cid0 < 0) return;
	%cCount = %list.getCount();
	if(%cid0 >= %cCount) return;
	%x0 = getWord(%vec0, 1);
	%y0 = getWord(%vec0, 2);
	if(%x0 < 0 || %y0 < 0) return;
	%chest0 = %list.getObject(%cid0);
	if(%x0 >= %chest0.width || %y0 >= %chest0.height) return;
	if(!isObject(%orphans = DistrictContainerlessItems))
		new SimSet(DistrictContainerlessItems);
	if(isObject(%data = %chest0.slot[%x0, %y0]))
		DistrictContainerlessItems.add(%data);
	%item = new Item()
	{
		client = %cl;
		datablock = SomethingToDoWithTheItem;
		districtItemData = %data;
		position = %pl.getPosition();
		velocity = %pl.getVelocity();
	};
	%data.physicalItem = %item;
}

function servercmdDistrictCSwap(%cl, %vec0, %vec1)
{
	if(!isObject(%list = DistrictContainerList)) return;
	%cid0 = getWord(%vec0, 0);
	%cid1 = getWord(%vec1, 0);
	if(%cid0 < 0 || %cid1 < 0) return;
	%cCount = %list.getCount();
	if(%cid0 >= %cCount || %cid1 >= %cCount) return;
	%x0 = getWord(%vec0, 1);
	%y0 = getWord(%vec0, 2);
	%x1 = getWord(%vec1, 1);
	%y1 = getWord(%vec1, 2);
	if(%x0 < 0 || %y0 < 0 || %x1 < 0 || %y1 < 0) return;
	%chest0 = %list.getObject(%cid0);
	%chest1 = %list.getObject(%cid1);
	if(%x0 >= %chest0.width || %y0 >= %chest0.height || %x1 >= %chest1.width || %y1 >= %chest0.height) return;
	%temp = %chest0.slot[%x0, %y0];
	%chest0.slot[%x0, %y0] = %chest1.slot[%x1, %y1];
	%chest1.slot[%x1, %y1] = %temp;
}