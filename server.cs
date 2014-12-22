$District::ServerRevision = 1;

package DistrictServer
{
	function GameConnection::AutoAdminCheck(%cl, %a, %b, %c)
	{
		commandToServer(%cl, 'District_HandshakePing', $District::ServerRevision);
		return Parent::AutoAdminCheck(%cl, %a, %b, %c);
	}
};
activatePackage("DistrictServer");

function District_HandshakePong(%cl, %value)
{
	%cl.DistrictRevision = %value;
	%cl.HasDistrictClient = 1;
}

exec("./lib/init.cs");
exec("./src/init.cs");