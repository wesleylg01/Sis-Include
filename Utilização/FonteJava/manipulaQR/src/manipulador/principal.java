package manipulador;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

import javax.swing.JOptionPane;

import com.google.zxing.EncodeHintType;
import com.google.zxing.NotFoundException;
import com.google.zxing.WriterException;
import com.google.zxing.qrcode.decoder.ErrorCorrectionLevel;

public class principal {
	
	static String caminho;
	static String charset = "UTF-8"; // or "ISO-8859-1"
	static Map<EncodeHintType, ErrorCorrectionLevel> hintMap = new HashMap<EncodeHintType, ErrorCorrectionLevel>();
	

	
	public static void main(String[] args) {
		
    caminho = args[0];
 //   JOptionPane.showMessageDialog(null, caminho);
 // criação de qrcode
    if (caminho.substring(caminho.length()-3, caminho.length()).equals("txt"))
       {
    	File file = new File(caminho);  
    	     try {  
    	    	 Scanner arq = new Scanner(file); 
    	    	 String linha = "";
    	    	 int numArq = 0;
    	         while (arq.hasNextLine()) {  
    	        	  linha = linha + arq.nextLine();  
    	             if (linha.length()>=1000){
    	            	 gerarQr(linha, numArq);
    	            	 linha="";
    	            	 numArq++;
    	             }
    	            	 
    	             }  
    	         numArq++;
    	         gerarQr(linha, numArq);
    	         arq.close();  
    	        } catch (IOException ioe) {  
    	            ioe.printStackTrace();  
    	        }  
      }
    else
    {
    	String caminhoImgs = caminho.substring(0, caminho.length()-19)+"\\qrCode"; 	
    	File file = new File(caminhoImgs);  
    	int count = file.listFiles().length-1;
    	LerQr(caminhoImgs+"\\", count);
    }
    }
    	  
    private static void gerarQr(String txt, int arq){
    	hintMap.put(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.L);
    	conversor converter = new conversor();
    	try {
    		String NovoCaminho = caminho.substring(0, caminho.length()-19)+"\\qrCode\\"+String.valueOf(arq)+".png"; 
    		converter.createQRCode(txt, NovoCaminho, charset, hintMap, 243, 243);
    	//	JOptionPane.showMessageDialog(null, "QrCode Gerado");    
    	} catch (WriterException | IOException e) {
	     //TODO Auto-generated catch block
    		e.printStackTrace();
        }
       }
    
    private static void LerQr(String caminhoImgs, int qtde){
		hintMap.put(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.L);
    	conversor converter = new conversor();
    	String linha="";
    	PrintWriter pw = null;
		try {
			pw = new PrintWriter (new FileOutputStream(caminho.substring(0,caminho.length()-4) + ".txt",false),false);
			System.out.println(caminho.substring(0,caminho.length()-4));
		} catch (FileNotFoundException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}  
    	for (int i = 0; i<= qtde; i++){

					try {
						linha = linha+ converter.readQRCode(caminhoImgs+String.valueOf(i)+".png", charset, hintMap);
						pw.print(linha);
						pw.write(13);  
						pw.write(10);  
					} catch (NotFoundException | IOException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				
    }
    	
    	
    	pw.close();  
    }
}


  

