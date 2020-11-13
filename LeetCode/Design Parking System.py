# Runtime: 136 ms, faster than 71.72% of Python3 online submissions
# Memory Usage: 14.6 MB, less than 49.62% of Python3 online submissions

class ParkingSystem:

    def __init__(self, big: int, medium: int, small: int):
        self.count = [0, big, medium, small]

    def addCar(self, carType: int) -> bool:
        self.count[carType] -= 1
        return self.count[carType] >= 0
