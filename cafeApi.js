
import { useQuery, useMutation } from 'react-query';
import axios from 'axios';

export const useCafes = (location) => {
    return useQuery(['cafes', location], () =>
        axios.get(/api/cafes ? location = ${ location }).then((res) => res.data)
    );
};

export const useCreateCafe = () => {
    return useMutation((newCafe) =>
        axios.post('/api/cafes', newCafe).then((res) => res.data)
    );
};

