
import React from 'react';
import { AgGridReact } from 'ag-grid-react';
import { useCafes } from '../api/cafeApi';
import { Button } from '@mui/material';

const CafePage = () => {
    const { data: cafes, isLoading } = useCafes();

    const columns = [
        { headerName: 'Logo', field: 'logo', cellRenderer: 'LogoRenderer' },
        { headerName: 'Name', field: 'name' },
        { headerName: 'Description', field: 'description' },
        { headerName: 'Employees', field: 'employees' },
        { headerName: 'Location', field: 'location' },
        {
            headerName: 'Actions',
            field: 'actions',
            cellRendererFramework: (params) => (
                <Button>Edit/Delete</Button>
            ),
        },
    ];

    return (
        <div style={{ height: 600, width: '100%' }}>
            <AgGridReact
                rowData={cafes}
                columnDefs={columns}
                loadingOverlayComponentFramework={isLoading}
            />
        </div>
    );
};

export default CafePage;

