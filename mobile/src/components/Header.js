import React from 'react';
import {View} from 'react-native';
import {Header as HeaderNative} from 'react-native-elements';

import theme from '../theme/default';

export default Header = () => {
  return (
    <View>
      <HeaderNative
        statusBarProps={{barStyle: 'light-content'}}
        barStyle="light-content" // or directly
        centerComponent={{
          text: 'ToDo List',
          style: {color: '#fff', fontSize: 18, fontWeight: 'bold'},
        }}
        containerStyle={{
          backgroundColor: theme.primary,
          justifyContent: 'space-around',
          paddingTop: 0,
          height: 50,
        }}
      />
    </View>
  );
};
