def min_dif_element(arr):
    arr.sort()
    arr_size = len(arr)
    min_dif = 9999*9999
    first_num = int
    second_num = int


    for i in range(arr_size-1):
        if (arr[i+1]-arr[i]<min_dif):
            min_dif = arr[i+1]-arr[i]

        return min_dif

arr = [1,4,2,6,7,11,40,22,90,12,10]
print(min_dif_element(arr))