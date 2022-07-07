%6.11

prost(_,1):-!.
prost(X,I):-Cur is X mod I, Cur \= 0, I1 is I - 1, prost(X,I1), !.
prost(X):-X > 1, I is X - 1, prost(X,I), !.

div(X,I):-Cur is X mod I, Cur = 0.

sum(_,1,Sum,Sum):-!.
sum(X,I,Sum,Sum_cur):-div(X,I), not(prost(I)), Sum1 is Sum_cur + I, I1 is I - 1, sum(X,I1,Sum,Sum1), !.
sum(X,I,Sum,Sum_cur):-I1 is I - 1, sum(X,I1,Sum,Sum_cur).
sum(X,Sum):-I is X-1, sum(X,I,Sum,0).

%6.12
prost(_,1):-!.
prost(X,I):-Cur is X mod I, Cur \= 0, I1 is I - 1, prost(X,I1), !.
prost(X):-X > 1, I is X - 1, prost(X,I), !.

vz_prost(1,_).
vz_prost(X,Y):-X \= 0, X1 is Y mod X, vz_prost(X1,X),!.

div(X,I):-Cur is X mod I, Cur = 0.

sodp(0,Sum,Sum):-!.
sodp(X,S,Sum):-X1 is X div 10, Cur is X mod 10, prost(Cur), Sum1 is Sum + Cur, sodp(X1,S,Sum1), !.
sodp(X,S,Sum):-X1 is X div 10, sodp(X1,S,Sum).
sum_of_dig_prost(X,Sum):-sodp(X,Sum,0).

pr(X,_,X,N,N):-!.
pr(X,Sod,I,N,Num):-not(div(X,I)), not(vz_prost(X,I)), vz_prost(I,Sod),I1 is I + 1, Num1 is Num + 1, pr(X,Sod,I1,N,Num1).
pr(X,Sod,I,N,Num):-I1 is I + 1, pr(X,Sod,I1,N,Num).
pr(X,N):-sum_of_dig_prost(X,Sod), pr(X,Sod,1,N,0), !.

%6.14
list_length([],N,N):-!.
list_length([_|T],N,N_cur):-N1 is N_cur + 1, list_length(T,N,N1).
list_length(List,N):-list_length(List,N,0), !.

%6.15
%Список(in), индекс(in), элемент(in/out).
%Возвращает элемент списка по указанному индексу, или проверяет его равенство введённому значению.
num_by_ind([El|_],0,El):-!.
num_by_ind([_|T],I,El):-I1 is I - 1, num_by_ind(T,I1,El).


list_min([],Min,Min):-!.
list_min([H|T],M,Min):-H < Min, list_min(T,M,H), !.
list_min([_|T],M,Min):-list_min(T,M,Min).

%Список(in), Min(out).
%Возвращает минимальный элемент в списке.
list_min([H|T],Min):-list_min(T,Min,H).

pr15(List,Ind):-list_min(List,Min), num_by_ind(List,Ind,Min).

%6.17
first_min_ind([],Ind,Ind,_,_):-!.
first_min_ind([H|T],I,_,Ind,Min):-H < Min, I1 is Ind + 1, first_min_ind(T,I,Ind,I1,H), !.
first_min_ind([_|T],I,Ind_min,Ind,Min):-I1 is Ind + 1, first_min_ind(T,I,Ind_min,I1,Min).

%first_min_ind(+List,-Ind), Возвращает индекс первого минимального элемента(начиная с 0)
first_min_ind([H|T],Index):-first_min_ind(T,Index,0,1,H), !.


%out_elements(+List,+Num,-El)
%поочерёдно присваивает переменной El первые Num элементов List
out_elements(_,0,_):-!.
out_elements([H|_],_,H).
out_elements([_|T],I,H):-I1 is I-1, out_elements(T,I1,H).


%pr17(+List,-El)
%поочерёдно присваивает переменной El все элементы List, стоящие до первого минимального.
pr17(List,El):-first_min_ind(List,Ind), out_elements(List,Ind,El).
