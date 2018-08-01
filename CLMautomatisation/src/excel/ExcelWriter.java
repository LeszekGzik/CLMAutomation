package excel;

import java.io.*;
import java.util.List;

import org.apache.poi.hssf.usermodel.HSSFRow;
import org.apache.poi.hssf.usermodel.HSSFSheet;
import org.apache.poi.hssf.usermodel.HSSFWorkbook;
import org.apache.poi.ss.usermodel.Cell;

/** Klasa realizuj�ca zapis danych do pliku .xls */
public class ExcelWriter {
	
	/** Tworzy lub nadpisuje plik .xls o podanej �cie�ce i zapisuje do niego list� wierszy. 
	 * @param	filePath	Pe�na �cie�ka do pliku kt�ry ma by� utworzony/nadpisany (w��cznie z nazw� i rozszerzeniem!) 
	 * @param 	title		Tytu� arkusza do kt�rego dane zostan� wpisane
	 * @param 	contents	Lista wierszy, gdzie ka�dy wiersz jest tablic� string�w. */
	public static void write(String filePath, String title, List<String[]> contents) {
		HSSFWorkbook workbook;
		workbook = new HSSFWorkbook();
		HSSFSheet sheet = workbook.createSheet(title);
		int rowNum = 0;
		
		for (String[] singleRow : contents) {
			HSSFRow row = sheet.createRow(rowNum++);
			int colNum = 0;
			for (String field : singleRow) {
				Cell cell = row.createCell(colNum++);
				cell.setCellValue((String)field);
			}
		}
		
		try {
			FileOutputStream fos = new FileOutputStream(new File(filePath));
			workbook.write(fos);
			workbook.close();
			fos.close();
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
	}
	
	/** Tworzy lub nadpisuje plik .xls o podanej �cie�ce i zapisuje do niego tablic� wierszy. 
	 * @param	filePath	Pe�na �cie�ka do pliku kt�ry ma by� utworzony/nadpisany (w��cznie z nazw� i rozszerzeniem!) 
	 * @param 	title		Tytu� arkusza do kt�rego dane zostan� wpisane
	 * @param 	contents	Tablica wierszy, gdzie ka�dy wiersz jest tablic� string�w. */
	public static void write(String filePath, String title, String[][] contents) {
		HSSFWorkbook workbook;
		workbook = new HSSFWorkbook();
		HSSFSheet sheet = workbook.createSheet(title);
		int rowNum = 0;
		
		for (String[] singleRow : contents) {
			HSSFRow row = sheet.createRow(rowNum++);
			int colNum = 0;
			for (String field : singleRow) {
				Cell cell = row.createCell(colNum++);
				cell.setCellValue((String)field);
			}
		}
		
		try {
			FileOutputStream fos = new FileOutputStream(new File(filePath));
			workbook.write(fos);
			workbook.close();
			fos.close();
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
	}

	/** Dopisuje wiersze do istniej�cego pliku .xls.
	 * Nowe wiersze zostan� dopisane na ko�cu, za ostatnim fizycznie istniej�cym wierszem.
	 * @param	filePath	Pe�na �cie�ka do pliku kt�ry ma by� zmieniony (w��cznie z nazw� i rozszerzeniem!) 
	 * @param	newContent	Tablica wierszy, gdzie ka�dy wiersz jest tablic� string�w. */
	public static void append(String filePath, String[][] newContent) {
		HSSFWorkbook workbook;
		try {
			FileInputStream fis = new FileInputStream(new File(filePath));
			workbook = new HSSFWorkbook(fis);
			HSSFSheet sheet = workbook.getSheetAt(0);
			int rowNum = sheet.getLastRowNum();

			for (String[] singleRow : newContent) {
				HSSFRow row = sheet.createRow(++rowNum);
				int colNum = 0;
				for (String field : singleRow) {
					Cell cell = row.createCell(colNum++);
					cell.setCellValue((String)field);
				}
			}	
			fis.close();
			FileOutputStream fos = new FileOutputStream(filePath);
			workbook.write(fos);
			workbook.close();
			fos.close();
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
	}
	
	/** Dopisuje wiersze do istniej�cego pliku .xls.
	 * Nowe wiersze zostan� dopisane na ko�cu, za ostatnim fizycznie istniej�cym wierszem.
	 * @param	filePath	Pe�na �cie�ka do pliku kt�ry ma by� zmieniony (w��cznie z nazw� i rozszerzeniem!) 
	 * @param	newContent	Lista wierszy, gdzie ka�dy wiersz jest tablic� string�w. */
	public static void append(String filePath, List<String[]> newContent) {
		HSSFWorkbook workbook;
		try {
			FileInputStream fis = new FileInputStream(new File(filePath));
			workbook = new HSSFWorkbook(fis);
			HSSFSheet sheet = workbook.getSheetAt(0);
			int rowNum = sheet.getLastRowNum();

			for (String[] singleRow : newContent) {
				HSSFRow row = sheet.createRow(++rowNum);
				int colNum = 0;
				for (String field : singleRow) {
					Cell cell = row.createCell(colNum++);
					cell.setCellValue((String)field);
				}
			}	
			fis.close();
			FileOutputStream fos = new FileOutputStream(filePath);
			workbook.write(fos);
			workbook.close();
			fos.close();
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
	}
	
	/** Dopisuje wiersze z liczbami ca�kowitymi do istniej�cego pliku .xls.
	 * Nowe wiersze zostan� dopisane na ko�cu, za ostatnim fizycznie istniej�cym wierszem.
	 * @param	filePath	Pe�na �cie�ka do pliku kt�ry ma by� zmieniony (w��cznie z nazw� i rozszerzeniem!) 
	 * @param	newContent	Lista wierszy, gdzie ka�dy wiersz jest tablic� int�w. */
	public static void appendWithInt(String filePath, List<Integer[]> newContent) {
		HSSFWorkbook workbook;
		try {
			FileInputStream fis = new FileInputStream(new File(filePath));
			workbook = new HSSFWorkbook(fis);
			HSSFSheet sheet = workbook.getSheetAt(0);
			int rowNum = sheet.getLastRowNum();

			for (Integer[] singleRow : newContent) {
				HSSFRow row = sheet.createRow(++rowNum);
				int colNum = 0;
				for (Integer field : singleRow) {
					Cell cell = row.createCell(colNum++);
					cell.setCellValue((Integer)field);
				}
			}	
			fis.close();
			FileOutputStream fos = new FileOutputStream(filePath);
			workbook.write(fos);
			workbook.close();
			fos.close();
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
	}
	
	/** Dopisuje wiersze z liczbami ca�kowitymi do istniej�cego pliku .xls.
	 * Nowe wiersze zostan� dopisane na ko�cu, za ostatnim fizycznie istniej�cym wierszem.
	 * @param	filePath	Pe�na �cie�ka do pliku kt�ry ma by� zmieniony (w��cznie z nazw� i rozszerzeniem!) 
	 * @param	newContent	Tablica wierszy, gdzie ka�dy wiersz jest tablic� int�w. */
	public static void appendWithInt(String filePath, Integer[][] newContent) {
		HSSFWorkbook workbook;
		try {
			FileInputStream fis = new FileInputStream(new File(filePath));
			workbook = new HSSFWorkbook(fis);
			HSSFSheet sheet = workbook.getSheetAt(0);
			int rowNum = sheet.getLastRowNum();

			for (Integer[] singleRow : newContent) {
				HSSFRow row = sheet.createRow(++rowNum);
				int colNum = 0;
				for (Integer field : singleRow) {
					Cell cell = row.createCell(colNum++);
					cell.setCellValue((Integer)field);
				}
			}	
			fis.close();
			FileOutputStream fos = new FileOutputStream(filePath);
			workbook.write(fos);
			workbook.close();
			fos.close();
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
	}
}
