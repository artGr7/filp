woman(lisa).
woman(marge).
woman(maggie).
man(homer).
man(bart).
man(abraham).

parent(marge, lisa).
parent(homer, lisa).
parent(marge, bart).
parent(homer, bart).
parent(marge, maggie).
parent(homer, maggie).

parent(abraham, homer)
parent(baba_simpson, homer)

/* Построить предикат daughter(X, Y), который проверяет,
является ли X дочерью Y. Построить предикат, daughter(X), который
выводит дочь X. */

daughter(X):- parent(X, Y), woman(Y), print(Y).
daughter(X,Y):- parent(Y, X), woman(X).

/*Построить предикат husband(X, Y), который проверяет,
является ли X мужем Y. Построить предикат husband(X), который
выводит мужа X. */

husband(X,Y):- parent(X,Z), parent(Y,Z), woman(Y), man(X).
husband(X):- parent(X,Z), parent(Y,Z), woman(X), man(Y), print(Y).

/*Построить предикат grand_son(X, Y), который проверяет,
является ли X внуком Y. Построить предикат grand_sons(X), который
выводит всех внуков X. */

grand_son(X,Y):- parent(Z,X), parent(Y,Z), man(X).
grand_son(X):- parent(X,Z), parent(Z,Y), man(Y), print(Y).

/* Построить предикат grand_ma_and_daughter(X,Y), который
проверяет, являются ли X и Y бабушкой и внучкой или внучкой и
бабушкой. */
grand_ma(X,Y) :- woman(X), parent(Z,Y), parent(X,Z). 
grand_ma_and_daughter(X,Y) :- woman(Y), woman(X), (grand_ma(X,Y);grand_ma(Y,X)).

% Найти минимальную цифру числа.
minDigitUp(0,9) :- !.
minDigitUp(X,Digit) :- X1 is X div 10, minDigitUp(X1,Dig1), Dig2 is X mod 10, (Dig1 < Dig2, Digit is Dig1; Digit is Dig2), !.

% Найти минимальную цифру числа с помощью рекурсии вниз
minDigitDown(N, X) :- minDigitDown(N, 9, X).
minDigitDown(0, X, X) :- !.
minDigitDown(N, Digit, X) :- N1 is N div 10, Dig is N mod 10, Dig < Digit, !, minDigitDown(N1, Dig, X); 
N2 is N div 10, minDigitDown(N2, Digit, X).
