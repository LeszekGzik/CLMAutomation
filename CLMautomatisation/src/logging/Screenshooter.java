package logging;

import java.io.File;
import java.io.IOException;
import org.apache.commons.io.FileUtils;
import org.openqa.selenium.OutputType;
import org.openqa.selenium.TakesScreenshot;
import org.openqa.selenium.WebDriver;

/** Klasa do robienia screenów. */
public class Screenshooter {
	public String folder;
	public WebDriver driver;
	
	public Screenshooter(WebDriver driver, String pathToFolder) {
		this.driver = driver;
		folder = pathToFolder;
	}
	
	/** Robi zrzut ekranu z WebDrivera i wrzuca go do folderu pod nazw¹ FILENAME.  */
	public void take(String fileName) throws IOException {
        File scrFile = ((TakesScreenshot)driver).getScreenshotAs(OutputType.FILE);
        FileUtils.copyFile(scrFile, new File(folder + fileName + ".png"));
	}
}
