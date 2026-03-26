#include <iostream>

std::string customer(std::string name) {

    return name;
}

void guide() {

    std::cout << "님이 자기 포인트가 얼마 적립되어 있는지 알려달라고 한다." << std::endl;
}

int check(int bananamilk, int egg) {

    int total = bananamilk + egg;

    return total;

}

void pointcard(int number) {

    std::cout << "님의 현재 적립된 포인트는 " << number << "포인트 이다." << std::endl;
}

int main()
{
    std::cout << "손님의 이름은 " << customer("피쿵츄") << "이다." << std::endl;
    std::cout << customer("피쿵츄") << "님이 계산해달라고 한다." << std::endl;
    std::cout << "총액은: " << check(1200, 5980) << "이다." << std::endl;
    std::cout << customer("피쿵츄");
    guide();
    std::cout << customer("피쿵츄");
    pointcard(7777);

    return 0;
}