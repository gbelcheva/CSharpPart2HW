<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">

    <xsl:template match="/">
      <html>
        <body>
          <h1>Catalogue (XSL)</h1>
          <table bgcolor="grey" cellspacing="1">
            <tr bgcolor="white">
              <th>Album</th>
              <th>Artist</th>
              <th>Year</th>
              <th>Producer</th>
              <th>Price</th>
              <th>Songs</th>
            </tr>
            <xsl:for-each select="/catalogue/album">
              <tr bgcolor="white">
                <td>
                  <xsl:value-of select="name"/>
                </td>
                <td>
                  <xsl:value-of select="artist"/>
                </td>
                <td>
                  <xsl:value-of select="year"/>
                </td>
                <td>
                  <xsl:value-of select="producer"/>
                </td>
                <td>
                  <xsl:value-of select="price"/>
                </td>
                <td>
                  <xsl:for-each select="songs/song">
                    <xsl:value-of select="title"/> [<xsl:value-of select="duration"/>]
                    <br />
                  </xsl:for-each>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
