import React from 'react';
import {StyleSheet, Text, FlatList} from 'react-native';

import ListItem from './ListItem';

const mockup = [
  {
    id: '01',
    description: 'Task description 01...',
    state: 1,
  },
  {
    id: '02',
    description: 'Task description 02...',
    state: 2,
  },
  {
    id: '03',
    description: 'Task description 03...',
    state: 3,
  },
  {
    id: '04',
    description: 'Task description 04...',
    state: 1,
  },
  {
    id: '05',
    description: 'Task description 05...',
    state: 2,
  },
  {
    id: '06',
    description: 'Task description 06...',
    state: 3,
  },
  {
    id: '07',
    description: 'Task description 07...',
    state: 1,
  },
  {
    id: '08',
    description: 'Task description 08...',
    state: 2,
  },
  {
    id: '09',
    description: 'Task description 09...',
    state: 3,
  },
];

export default List = () => {
  return (
    <>
      <Text style={styles.header}>All Tasks</Text>

      <FlatList
        contentContainerStyle={{paddingBottom: 10}}
        style={styles.listContainer}
        data={mockup}
        renderItem={({item}) => <ListItem item={item} />}
        keyExtractor={item => item.id}
      />
    </>
  );
};

const styles = StyleSheet.create({
  header: {
    fontSize: 20,
    fontWeight: 'bold',
    marginVertical: 16,
    marginLeft: 16,
  },
  listContainer: {},
});
