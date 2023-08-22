Algoritmo parcialprogramacion
	Definir base, altura, distancia Como real;
	Definir areaBase, areaLateral, volumen, diagonal como real;
	Definir cantidadPrismas como entero;
	
	cantidadPrismas <-0;
	
	Repetir
		Escribir Sin Saltar"Ingrese la base del prisma: ";
		leer base;
		
		si base <> 0 Entonces
			Escribir Sin Saltar "Ingrese la altura del prisma: ";
			leer altura;
			Escribir Sin Saltar "Ingrese la distancia del prisma: ";
			leer distancia;
			
			areaBase=2*(base*altura);
			areaLateral=3*(distancia*altura);
			volumen=areaBase*altura;
			diagonal=raiz(base^2+altura^2);
			
			Escribir "Área base:", areaBase;
			Escribir "Area lateral:", areaLateral;
			Escribir "Volúmen:", volumen;
			Escribir "Diagonal:", diagonal;
			
			cantidadPrismas<-cantidadPrismas+1;
		FinSi
	Hasta Que base = 0;
	Escribir "Cantidad de prismas ingresados:", cantidadPrismas;
FinAlgoritmo
