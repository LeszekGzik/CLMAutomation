package logging;

import java.io.IOException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Properties;

import org.openqa.selenium.WebDriver;
import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

import excel.ExcelWriter;

public class ReportManager {
	/** Zmienna statyczna informuj¹ca o tym, czy powinien zostaæ utworzony nowy raport w Excel'u */
	public static boolean makeNewReport = true;
	public Screenshooter screenshooter;
	public Logger logger;
	public String xlsFile;
	public String xlsSheet;
	/** Poziomy raportowania. Okreœla kiedy powinny byæ wykonywane zrzuty ekranu/logi/wpisy do raportu.
	 * 0 - DEBUG; wpisy wykonywane po ka¿dym poleceniu.
	 * 1 - STEP; wpisy wykonywane po ka¿dym kroku (jeœli nie zosta³ pominiêty) oraz przy wyst¹pieniu b³êdu.
	 * 2 - TEST; wpisy wykonywane na koniec testu oraz przy wyst¹pieniu b³êdu.
	 * 3 - SCENARIO; wpisy wykonywane na koniec scenariusza oraz przy wyst¹pieniu b³êdu.
	 * 4 - ERROR; wpisy wykonywane tylko przy wyst¹pieniu b³êdu.
	 * 5 - SCR; wpisy nie s¹ nigdy wykonywane samoczynnie. Nadal mo¿na u¿yæ polecenia SCR aby wykonaæ zrzut ekranu.
	 * 6 - NEVER; wpisy nie s¹ nigdy wykonywane samoczynnie. Ignoruje polecenia SCR.
	 * */
	public int loggingLevel;
	public int reportingLevel;
	public int screenshootingLevel;
	
	public ReportManager(WebDriver driver, Properties properties) {
		screenshooter = new Screenshooter(driver, properties.getProperty("screenfolder"));
		logger = LogManager.getLogger(ReportManager.class);
		xlsFile = properties.getProperty("xlsoutput");
		xlsSheet = properties.getProperty("xlssheet");
		
		
		switch(properties.getProperty("logginglevel").toLowerCase()) {
		case "debug":
			loggingLevel = 0;
			break;
		case "step":
			loggingLevel = 1;
			break;
		case "test":
			loggingLevel = 2;
			break;
		case "scenario":
			loggingLevel = 3;
			break;
		case "error":
			loggingLevel = 4;
			break;
		case "scr":
			loggingLevel = 5;
			break;
		case "never":
			loggingLevel = 6;
			break;
		}
		
		switch(properties.getProperty("reportinglevel").toLowerCase()) {
		case "debug":
			reportingLevel = 0;
			if (makeNewReport) {
				if(properties.getProperty("automode").toLowerCase()=="true") {
					
				}
				String[][] contents = {{"Scenario", "Test", "Step", "Command", "Status", "Time stamp"}};
				ExcelWriter.write(xlsFile, xlsSheet, contents);
				makeNewReport = false;
			}
			break;
		case "step":
			reportingLevel = 1;
			if (makeNewReport) {
				String[][] contents = {{"Scenario", "Test", "Step", "Status", "Time stamp"}};
				ExcelWriter.write(xlsFile, xlsSheet, contents);
				makeNewReport = false;
			}
			break;
		case "test":
			reportingLevel = 2;
			if (makeNewReport) {
				String[][] contents = {{"Scenario", "Test", "Status", "Time stamp"}};
				ExcelWriter.write(xlsFile, xlsSheet, contents);
				makeNewReport = false;
			}
			break;
		case "scenario":
			reportingLevel = 3;
			if (makeNewReport) {
				String[][] contents = {{"Scenario", "Status", "Time stamp"}};
				ExcelWriter.write(xlsFile, xlsSheet, contents);
				makeNewReport = false;
			}
			break;
		case "error":
			reportingLevel = 4;
			break;
		case "scr":
			reportingLevel = 5;
			break;
		case "never":
			reportingLevel = 6;
			break;
		}
		
		switch(properties.getProperty("screenshootinglevel").toLowerCase()) {
		case "debug":
			screenshootingLevel = 0;
			break;
		case "step":
			screenshootingLevel = 1;
			break;
		case "test":
			screenshootingLevel = 2;
			break;
		case "scenario":
			screenshootingLevel = 3;
			break;
		case "error":
			screenshootingLevel = 4;
			break;
		case "scr":
			screenshootingLevel = 5;
			break;
		case "never":
			screenshootingLevel = 6;
			break;
		}
	}
	
	public void debug(String... args) throws IOException {
		if (loggingLevel<=0) {
			String message = "DEBUG";
			for (String s : args) {
				message += " " + s;
			}
			logger.info(message);
		}
		if (screenshootingLevel<=0) {
			screenshooter.take(formattedDateTime());
		}
		if (reportingLevel==0) {
			String[][] contents = {args};
			ExcelWriter.append(xlsFile, contents);
		}
	}
	
	public void step(String... args) throws IOException {
		if (loggingLevel<=1) {
			String message = "STEP ";
			for (String s : args) {
				message += " " + s;
			}
			logger.info(message);
		}
		if (screenshootingLevel<=1) {
			screenshooter.take(formattedDateTime());
		}
		if (reportingLevel==1) {
			String[][] contents = {args};
			ExcelWriter.append(xlsFile, contents);
		}
	}
	
	public void test(String... args) throws IOException {
		if (loggingLevel<=2) {
			String message = "TEST ";
			for (String s : args) {
				message += " " + s;
			}
			logger.info(message);
		}
		if (screenshootingLevel<=2) {
			screenshooter.take(formattedDateTime());
		}
		if (reportingLevel==2) {
			String[][] contents = {args};
			ExcelWriter.append(xlsFile, contents);
		}
	}
	
	public void scenario(String... args) throws IOException {
		if (loggingLevel<=3) {
			String message = "SCENARIO ";
			for (String s : args) {
				message += " " + s;
			}
			logger.info(message);
		}
		if (screenshootingLevel<=3) {
			screenshooter.take(formattedDateTime());
		}
		if (reportingLevel==3) {
			String[][] contents = {args};
			ExcelWriter.append(xlsFile, contents);
		}
	}
	
	/** Zak³ada pierwszy argument jako nazwê screena, kolejne jako wiadomoœæ */
	public void error(String... args) throws IOException {
		if (loggingLevel<=4) {
			String message = "ERROR";
			for (int i = 1; i < args.length; i++) {
				String s = args[i];
				message += " " + s;
			}
			logger.error(message);
		}
		if (screenshootingLevel<=4) {
			screenshooter.take(args[0]);
		}
		if (reportingLevel==4) {
			String[][] contents = {args};
			ExcelWriter.append(xlsFile, contents);
		}
	}
	
	public void scr(String title) throws IOException {
		if (screenshootingLevel<=5) {
			screenshooter.take(title);
		}
	}

	/** Zwraca obecny czas w formacie yyyy-MM-dd HH:mm:ss */
	public static String currentDateTime() {
		DateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
		Date date = new Date();
		return dateFormat.format(date);
	}

	/** Zwraca obecny czas w formacie yyyy-MM-dd HH_mm_ss, na potrzeby nazw plików */
	public static String formattedDateTime() {
		DateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd HH_mm_ss");
		Date date = new Date();
		return dateFormat.format(date);
	}
}
