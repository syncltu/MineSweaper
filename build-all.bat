        SonarScanner.MSBuild.exe begin /k:"testingas" /o:"diroots" /d:sonar.login="${{ secrets.SONAR_TOKEN }}" /d:sonar.host.url="https://sonarcloud.io"
        MSBuild.exe /t:rebuild
        SonarScanner.MSBuild.exe end /d:sonar.login="${{ secrets.SONAR_TOKEN }}"