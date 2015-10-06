<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">

  <xsl:template match="/">
      <html>
        <body>
          <h1>Students</h1>
          <table bgcolor="grey" cellspacing="1">
            <tr bgcolor="white">
              <th>Name</th>
              <th>Sex</th>
              <th>Birth Date</th>
              <th>Course</th>
              <th>Speciality</th>
              <th>Faculty Number</th>
              <th>Taken Exams</th>
              <th>Enrolment</th>
              <th>Teacher's Endorsement</th>
            </tr>
            <xsl:for-each select="/students/student">
              <tr bgcolor="white">
                <td>
                  <xsl:value-of select="name"/>
                </td>
                <td>
                  <xsl:value-of select="sex"/>
                </td>
                <td>
                  <xsl:value-of select="birth-date"/>
                </td>
                <td>
                  <xsl:value-of select="course"/>
                </td>
                <td>
                  <xsl:value-of select="speciality"/>
                </td>
                <td>
                  <xsl:value-of select="faculty-number"/>
                </td>
                <td>
                  <xsl:for-each select="taken-exams/exam">
                    <xsl:value-of select="name"/>[<xsl:value-of select="score"/>]
                    <br />
                  </xsl:for-each>
                </td>
                <td>
                  <xsl:value-of select="enrolment/date"/> <br />
                  Entry exam score: <xsl:value-of select="enrolment/exam-score"/>
                </td>
                <td>
                  <xsl:for-each select="teachers-endorsements/endorsement">
                    <xsl:value-of select="current()"/>
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
