
# 1094 Car Pooling

# Time: nlogn
# Space: n


import heapq


def carPooling(self, trips: List[List[int]], capacity: int) -> bool:

    trips.sort(key = lambda t: t[1]) # sort by starting pos

    minHeap = [] # pair of [end, numPassengers]
    currPass = 0
    for t in trips:
        numPass, start, end = t
        while minHeap and minHeap[0][0] <= start:
            currPass -= minHeap[0][1]
            heapq.heappop(minHeap)

        currPass += numPass
        if currPass > capacity: 
            return False
        heapq.heappush(minHeap, [end, numPass])
    
    return True


        

