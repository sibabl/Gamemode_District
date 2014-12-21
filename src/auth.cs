$District::ServerRevision = 1;

function District_HandshakePong(%cl, %value)
{
	%cl.DistrictRevision = %value;
	%cl.HasDistrictClient = 1;
}

package District_Server_Auth
{
	function GameConnection::AutoAdminCheck(%cl, %a, %b, %c)
	{
		commandToServer(%cl, 'District_HandshakePing', $District::ServerRevision);
		return Parent::AutoAdminCheck(%cl, %a, %b, %c);
	}
};
activatePackage("District_Server_Auth");