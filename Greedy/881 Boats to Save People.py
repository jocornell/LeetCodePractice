
# 881 Boats to Save People

# Limit of 2 people per boat

# Greedy
# Sort

# Time: nlogn (sort)

def numRescueBoats(self, people: List[int], limit: int) -> int:
    
    people.sort()

    res = 0
    l, r = 0, len(people) - 1

    while l <= r:
        remaining = limit - people[r]
        r -= 1
        res += 1
        if l <= r and remaining >= people[l]:
            l += 1

    return res