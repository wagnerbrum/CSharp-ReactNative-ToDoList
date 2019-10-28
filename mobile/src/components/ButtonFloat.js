import React from 'react';
import {TouchableOpacity, StyleSheet} from 'react-native';
import Icon from 'react-native-vector-icons/Feather';

import theme from '../theme/default';

export default ButtonFloat = () => {
  return (
    <TouchableOpacity style={styles.buttonAdd} activeOpacity={0.8}>
      <Icon name="plus" style={styles.iconAdd} />
    </TouchableOpacity>
  );
};

const styles = StyleSheet.create({
  buttonAdd: {
    width: 56,
    height: 56,
    backgroundColor: theme.primary,
    justifyContent: 'center',
    alignItems: 'center',
    position: 'absolute',
    borderRadius: 28,
    right: 16,
    bottom: 16,
    shadowColor: 'red',
    elevation: 5,
  },
  iconAdd: {
    fontSize: 24,
    color: 'white',
  },
});
