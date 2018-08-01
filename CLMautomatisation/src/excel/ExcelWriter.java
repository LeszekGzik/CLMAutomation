package excel;

import java.io.*;
import java.util.List;

import org.apache.poi.hssf.usermodel.HSSFRow;
import org.apache.poi.hssf.usermodel.HSSFSheet;
import org.apache.poi.hssf.usermodel.HSSFWorkbook;
import org.apache.poi.ss.usermodel.Cell;

/** Klasa realizuj¹ca zapis danych do pliku .xls */
public class ExcelWriter {
	
	/** Tworzy lub nadpisuje plik .xls o podanej œcie¿ce i zapisuje do niego listê wierszy. 
	 * @param	filePath	Pe³na œcie¿ka do pliku który ma byæ utworzony/nadpisany (w³¹cznie z nazw¹ i rozszerzeniem!) 
	 * @param 	title		Tytu³ arkusza do którego dane zostan¹ wpisane
	 * @param 	contents	Lista wierszy, gdzie ka¿dy wiersz jest tablic¹ stringów. */
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
	
	/** Tworzy lub nadpisuje plik .xls o podanej œcie¿ce i zapisuje do niego tablicê wierszy. 
	 * @param	filePath	Pe³na œcie¿ka do pliku który ma byæ utworzony/nadpisany (w³¹cznie z nazw¹ i rozszerzeniem!) 
	 * @param 	title		Tytu³ arkusza do którego dane zostan¹ wpisane
	 * @param 	contents	Tablica wierszy, gdzie ka¿dy wiersz jest tablic¹ stringów. */
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

	/** Dopisuje wiersze do istniej¹cego pliku .xls.
	 * Nowe wiersze zostan¹ dopisane na koñcu, za ostatnim fizycznie istniej¹cym wierszem.
	 * @param	filePath	Pe³na œcie¿ka do pliku który ma byæ zmieniony (w³¹cznie z nazw¹ i rozszerzeniem!) 
	 * @param	newContent	Tablica wierszy, gdzie ka¿dy wiersz jest tablic¹ stringów. */
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
	
	/** Dopisuje wiersze do istniej¹cego pliku .xls.
	 * Nowe wiersze zostan¹ dopisane na koñcu, za ostatnim fizycznie istniej¹cym wierszem.
	 * @param	filePath	Pe³na œcie¿ka do pliku który ma byæ zmieniony (w³¹cznie z nazw¹ i rozszerzeniem!) 
	 * @param	newContent	Lista wierszy, gdzie ka¿dy wiersz jest tablic¹ stringów. */
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
	
	/** Dopisuje wiersze z liczbami ca³kowitymi do istniej¹cego pliku .xls.
	 * Nowe wiersze zostan¹ dopisane na koñcu, za ostatnim fizycznie istniej¹cym wierszem.
	 * @param	filePath	Pe³na œcie¿ka do pliku który ma byæ zmieniony (w³¹cznie z nazw¹ i rozszerzeniem!) 
	 * @param	newContent	Lista wierszy, gdzie ka¿dy wiersz jest tablic¹ intów. */
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
	
	/** Dopisuje wiersze z liczbami ca³kowitymi do istniej¹cego pliku .xls.
	 * Nowe wiersze zostan¹ dopisane na koñcu, za ostatnim fizycznie istniej¹cym wierszem.
	 * @param	filePath	Pe³na œcie¿ka do pliku który ma byæ zmieniony (w³¹cznie z nazw¹ i rozszerzeniem!) 
	 * @param	newContent	Tablica wierszy, gdzie ka¿dy wiersz jest tablic¹ intów. */
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
