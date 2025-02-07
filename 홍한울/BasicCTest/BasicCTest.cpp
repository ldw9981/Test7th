#include <stdio.h>

int sumarray(int arr[], int s) {
	int sum = 0;
	for (int i = 0; i < s;i++) {
		sum += arr[i];
	}
	return sum;
}

int main()
{
	int a = 10;
	int b = 20;
	int c = 0;
	int array1[ ] = { 0,1,2,3,4,5,6,7,8,9 };

	//1. 2개의 int 를 더한 값을 리턴하는 add 함수를 만들고 a,b 입력의 리턴값을 c에 저장하세요.
		
	printf("c = %d\n", c);

	//2. 배열과 개수를 입력받아 의 총합을 계산하여 리턴하는 sum 함수를 만들고 호출하여 c에 저장하세요.
	
	int size = 0;
	size = sizeof(array1) / sizeof(array1[0]);
	c = sumarray(array1, size);
	printf("c = %d\n", c);

	//3. a,b의 메모리 주소를 입력하여 a,b의 값을 바꾸는 swap 함수를 만들어 a,b의 값을 바꾸세요.

	printf("a = %d, b = %d\n", a,b);
    return 0;
}
