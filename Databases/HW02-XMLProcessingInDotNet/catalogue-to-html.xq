xquery version "1.0";
declare option saxon:output "method=html";
  <html>
        <body>
          <h1>Catalogue (XQuery)</h1>
          <table bgcolor="white" cellspacing="1" border="1">
		  <thead>
				<tr bgcolor="white">
					<th>Album</th>
					<th>Artist</th>
					<th>Year</th>
					<th>Producer</th>
					<th>Price</th>
					<th>Songs</th>
				</tr>
			</thead>
			<tbody>
			{
			for $a in //catalogue/album
			return
				<tr> 
					<td>
						{string($a/name)}
					</td>
					<td>
						{string($a/artist)}
					</td>
					<td>
						{string($a/year)}
					</td>
					<td>
						{string($a/producer)}
					</td>
					<td>
						{string($a/price)}
					</td>
					<td>
					{
						for $s in $a/songs/song
						
						return
							(string($s/title), ' [', string($s/duration), ']', <br />)
					}
					</td>
		   </tr>
		   }
		   </tbody>
          </table>
        </body>
      </html>
    
